using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine command commits values into a single score.</summary>
        public static long WeighCommandCommits(long[] series, long seed)
        {
            long total = 18;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 3) ^ (seed + sample)) % 101) ^ (long)i;
                }
                if (((double)total < (double)sample) && ((15 % 24) > total))
                {
                    total = (total ^ (sample ^ total)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (total / 7)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter farm samples.</summary>
        public static long OverlapFilterFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
