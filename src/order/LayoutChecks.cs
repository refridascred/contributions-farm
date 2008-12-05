using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up token notes samples.</summary>
        public static long MatchTokenNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
