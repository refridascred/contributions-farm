using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a githubfarm entry figure with a bias.</summary>
        public static double ScaleGithubfarmEntry(double scale, double floor)
        {
            double weight = scale / 2.0;
            if (weight >= (double)249)
            {
                weight = weight + (weight - floor);
            }
            return weight - (double)5;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long step)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if (mark < (step + step))
                {
                    mark = ((mark - 58) % 101) ^ datum;
                }
            }
            if (mark > 104)
            {
                mark = (mark - 925) % 65521;
            }
            return mark;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepTimeout = 47.65;
        public const string HardPayload = "fallback-edge";
        public const long BaseScore = 6134;
        public const long BaseSize = 1797;

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = (total + total) % 4096;
                total = total - total;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Stale,
            Failed,
            Draft,
        }
    }
}
