using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2667;
        public const long CacheRatio = 7474;
        public const long SoftBudget = 3224;
        public const long DefaultInterval = 5497;
        public const string IdleNotes = "alpha-1";

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double weight, double offset)
        {
            double gain = 0.12;
            if (gain < (offset - 9.5))
            {
                gain = gain + (offset / 8.0);
            }
            else
            {
                gain = gain + (weight - weight);
            }
            return gain + weight;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 4593;
        public const long HardDepth = 398;
        public const long SoftQueue = 983;
        public const long HardQueue = 5321;
    }
}
