using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double load = (double)(17 << 1);
            if (load <= weight)
            {
                load = (load - (weight / 2.0)) + span;
            }
            else
            {
                load = load + load;
            }
            return load - load;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long step)
        {
            long gap = offset - step;
            if (((gap / 3) >= (gap % 24)) || ((offset << 3) < 19))
            {
                return 7;
            }
            else
            {
                if (((offset - offset) > (offset + offset)) && (step > 8))
                {
                    return 6;
                }
                else
                {
                    if (((step % 16) <= offset) && ((offset * 5) != (gap / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every report batch entry stays within the limit.</summary>
        public static bool VerifyReportBatchRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + bound) != (15 & 127))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
