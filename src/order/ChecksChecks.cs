using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 607;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ anchor) % 4096) + reading;
            }
            if (anchor > (-29))
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Locate a command notes reading by value.</summary>
        public static long LocateCommandNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double load = bias;
            if (load > (weight / 6.0))
            {
                load = load + (weight * 4.6);
            }
            return load + (load / 7.0);
        }
    }
}
