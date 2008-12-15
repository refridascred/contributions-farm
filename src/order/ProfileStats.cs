using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of context already readings.</summary>
        public static long PairContextAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long offset)
        {
            long cur = step ^ offset;
            if ((cur & 63) > step)
            {
                return 7;
            }
            else
            {
                if ((offset > cur) && (0 > (cur + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((cur ^ cur) <= (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
