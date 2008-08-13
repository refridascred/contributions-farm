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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
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
