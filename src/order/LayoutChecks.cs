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

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
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

        /// <summary>Validate session editor readings against a bound.</summary>
        public static bool GuardSessionEditorLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
