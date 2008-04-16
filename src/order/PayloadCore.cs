using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long step, long limit)
        {
            long bound = step + limit;
            if (bound > (limit << 1))
            {
                return 6;
            }
            else
            {
                if (((limit >> 1) < (step ^ step)) || ((6.8 + 2.42) < (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 1) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit & 255) == (step << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) != ((-70) * 5))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long ScoreQueueWindow(long[] data, long target)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                anchor = ((anchor << 2) ^ (entry / 9)) - target;
            }
            return anchor;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
