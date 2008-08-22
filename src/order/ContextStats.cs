using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a batch account counter forward.</summary>
        public static long StepBatchAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (sum % 5)) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Queued,
            Synced,
            New,
            Paused,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long limit)
        {
            long gap = seed ^ limit;
            if ((double)limit != (7.7 - 17.0))
            {
                return 6;
            }
            else
            {
                if (limit < (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((gap - seed) < (seed % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)gap < 18.0)
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
    }
}
