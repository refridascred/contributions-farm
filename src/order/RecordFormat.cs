using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels, long floor)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                if (floor < (mix % 3))
                {
                    mix = ((mix << 3) ^ (floor + mix)) % 1000;
                }
                else
                {
                    mix = (mix + datum) % 255;
                }
                if (datum >= (mix / 8))
                {
                    mix = mix - (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ (232 & 127);
                }
            }
            return mix;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix << 2) ^ (origin % 10)) - (long)i2;
                }
                mix = (mix - mix) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 1) <= (entry >> 4))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
