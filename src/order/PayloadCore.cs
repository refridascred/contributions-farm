using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit already layout readings against a rule.</summary>
        public static long CountAlreadyLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) < (tally - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (seed < (seed - seed))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) < (50 << 1))
                {
                    return 2;
                }
                else
                {
                    if (3.55 >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 97) <= (seed + floor))
                        {
                            return 8;
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
}
