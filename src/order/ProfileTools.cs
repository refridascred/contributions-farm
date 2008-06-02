using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally < (41 % 2))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate entry batches samples.</summary>
        public static long FoldEntryBatches(long[] values, long floor)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if (!((floor << 2) < ((long)values.Length - mix)))
                {
                    mix = (mix + floor) - reading;
                }
                mix = (mix * 4) + ((long)values.Length << 2);
            }
            if (mix < 947)
            {
                mix = (mix + (mix - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (long)i) % 255;
                result = (result + 35) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
