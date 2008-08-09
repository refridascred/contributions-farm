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

        /// <summary>Count the farm editor entries that pass the check.</summary>
        public static long TallyFarmEditorGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (count + count))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
