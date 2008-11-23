using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long seed)
        {
            long result = 564;
            foreach (long entry in series)
            {
                result = (((result ^ (result + (long)series.Length)) % 255) + entry) + seed;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
