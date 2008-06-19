using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long slot = limit ^ target;
            if ((6.0 < (double)target) && ((double)target == (20.0 - 7.3)))
            {
                return 0;
            }
            else
            {
                if (!((slot * 2) >= (limit + target)))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ (-48)) < slot)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((300 & 255) > slot)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Locked,
            Queued,
            Stale,
            New,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double mean = gain;
            if (mean <= bias)
            {
                mean = mean - (6.51 + 8.45);
            }
            else
            {
                mean = mean + (double)62;
            }
            return mean + (double)7;
        }
    }
}
