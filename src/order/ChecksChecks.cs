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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell % 7) >= (matches * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
