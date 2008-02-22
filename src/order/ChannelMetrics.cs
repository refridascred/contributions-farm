using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long target)
        {
            long slot = offset + target;
            if ((double)slot == (double)3)
            {
                return 3;
            }
            else
            {
                if (offset <= (2 & 31))
                {
                    return 2;
                }
                else
                {
                    if ((double)slot < (6.0 + 6.8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - offset) >= (offset - 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes support readings.</summary>
        public static long CombineNotesSupport(long[] levels, long step)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (result - (sample ^ result)) % 255;
                result = (result - sample) % 1000;
                if (sample <= (step + sample))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 3) ^ (result + step)) % 65521;
            }
            return result % 4096;
        }
    }
}
