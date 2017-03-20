using System;

namespace Common.Utilities
{
    /// <summary>Farm format helpers.</summary>
    public static class FarmFormat
    {
        /// <summary>Check whether a folder size is a power of two.</summary>
        public static bool IsFolderPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Interpolate between two githubfarm folder values.</summary>
        public static double LerpGithubfarmFolder(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
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

        /// <summary>Compute the greatest common divisor of two already sizes.</summary>
        public static long AlreadyGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }
    }
}
