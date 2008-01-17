using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            if ((offset + offset) != (seed ^ 51))
            {
                return 6;
            }
            else
            {
                if (offset >= (seed - offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 255) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset / 3) != (seed & 63)) && ((offset & 7) > (52 + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long origin)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score + (-50)) % 255) + origin;
                score = score - (cell / 7);
            }
            return score;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double ratio = (double)(86 % 60);
            if (ratio >= offset)
            {
                ratio = ratio - (4.89 / 4.0);
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Idle,
            Dropped,
            Pending,
            Stale,
        }
    }
}
