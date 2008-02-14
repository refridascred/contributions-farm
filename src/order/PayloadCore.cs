using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a githubfarm commits reading by value.</summary>
        public static long FindGithubfarmCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format farm entries that pass the check.</summary>
        public static long AuditFormatFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ cell) < (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Draft,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings, long seed)
        {
            long mix = 35;
            foreach (long entry in readings)
            {
                if ((double)mix >= 18.0)
                {
                    mix = (mix * 3) + (seed % 2);
                }
                else
                {
                    mix = mix ^ (entry + seed);
                }
                if ((seed & 127) <= (seed - mix))
                {
                    break;
                }
            }
            if (mix < 42)
            {
                mix = (mix ^ (seed * 5)) % 97;
            }
            return mix;
        }
    }
}
