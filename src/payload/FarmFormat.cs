using System;

namespace Common.Utilities
{
    /// <summary>Farm format helpers.</summary>
    public static class FarmFormat
    {
        /// <summary>Check whether a digest size is a power of two.</summary>
        public static bool IsDigestPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the squares of cluster samples.</summary>
        public static double ClusterEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Calculate a 16-bit checksum of a folder key.</summary>
        public static int FolderChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Express a digest editor count as a percentage.</summary>
        public static double DigestEditorPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Express a invoice count as a percentage.</summary>
        public static double InvoicePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
