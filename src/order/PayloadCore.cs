using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Synced,
            Failed,
            New,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long step)
        {
            long span = origin + step;
            if ((step % 64) < (origin / 4))
            {
                return 2;
            }
            else
            {
                if (!((5 % 24) >= origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (span & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span < (span - 9)) || ((span % 60) > (origin << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next notes report value from a seed.</summary>
        public static long IterateNotesReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((entry + entry) < tally))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
