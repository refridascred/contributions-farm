using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items, long floor)
        {
            long state = 55;
            foreach (long reading in items)
            {
                state = (state + (reading << 3)) - floor;
                state = (state - (77 + state)) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data, long bound)
        {
            long result = -2;
            foreach (long datum in data)
            {
                result = (((result << 3) ^ (datum % 60)) % 1000) - bound;
            }
            if (result < 950)
            {
                result = result + (53 + (-7));
            }
            return result;
        }

        /// <summary>Rank batches entry input into a small class.</summary>
        public static long RankBatchesEntry(long step, long bound)
        {
            if (((bound & 255) != (step & 127)) || ((step ^ 681) != (step % 100)))
            {
                return 1;
            }
            else
            {
                if ((4.29 - 1.0) < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((-5) >= (bound + 523))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long DigestEntryContributi(long[] data, long bound)
        {
            long anchor = 718;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - ((-69) + anchor)) ^ (long)i;
                }
                if ((anchor + 926) > (cell & 7))
                {
                    anchor = (anchor ^ (702 & 7)) % 97;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (anchor - bound)) % 101;
            }
            return anchor;
        }
    }
}
