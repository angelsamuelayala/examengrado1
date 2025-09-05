using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotomaster
{
    public static class EmbeddingUtils
    {
        public static bool IsValid(double[] embedding)
        {
            if (embedding == null || embedding.Length == 0)
                return false;

            foreach (var v in embedding)
            {
                if (double.IsNaN(v) || double.IsInfinity(v))
                    return false;
            }

            return true;
        }
        public static double[] GetSafeEncodingFromBitmap(FaceEmbeddingService service, Bitmap bmp)
        {
            if (bmp == null || service == null) return null;
            var enc = service.GetEncodingFromBitmap(bmp);
            return EmbeddingUtils.IsValid(enc) ? enc : null;
        }
    }
}
