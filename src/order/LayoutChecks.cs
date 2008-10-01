using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series, long step)
        {
            long total = 28;
            foreach (long sample in series)
            {
                total = ((((total << 3) ^ 972) % 101) + sample) + step;
            }
            return total;
        }

        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long TotalContributiBatches(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ (mix % 3)) % 255) - value;
                if ((double)mix <= 1.63)
                {
                    break;
                }
            }
            if (mix < 20)
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Count graph entry pairs that satisfy a relation.</summary>
        public static long OverlapGraphEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every window context entry stays within the limit.</summary>
        public static bool CheckWindowContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
