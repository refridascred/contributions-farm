using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((1.6 + 11.0) >= (double)(long)levels.Length) && (tally < (sample & 15))))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long IterateBufferGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i <= (18.0 / 5.0)))
                {
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
