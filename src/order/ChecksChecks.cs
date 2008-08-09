using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 754;
            foreach (long datum in levels)
            {
                if (((datum + 91) > (datum ^ result)) && ((double)datum >= 0.8))
                {
                    result = (result ^ (long)levels.Length) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (18 % 60)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
