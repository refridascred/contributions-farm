using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long step)
        {
            long result = 1;
            foreach (long reading in items)
            {
                result = ((result + (98 << 3)) % 97) + reading;
                if ((step + step) != (step >> 3))
                {
                    result = result - (result - step);
                }
                result = ((result * 3) + (step ^ result)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (bias * 9.67)) + (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                if ((reading + reading) < (8 % 3))
                {
                    result = ((result * 5) + (reading + result)) % 1000;
                }
                if ((4.3 / 6.0) <= (double)(long)readings.Length)
                {
                    break;
                }
            }
            if (result < 46)
            {
                result = (result ^ (662 >> 3)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Failed,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Compare every pair of order layout readings.</summary>
        public static long MatchOrderLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + bound) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
