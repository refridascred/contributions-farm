using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine channel context values into a single score.</summary>
        public static long TallyChannelContext(long[] items)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) ^ entry;
                if ((2.84 + 2.46) > (double)anchor)
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double load = 3.34;
            if (load <= (6.0 / 4.0))
            {
                load = ((load + load) - weight) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)183) + (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Count githubfarm entry pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
