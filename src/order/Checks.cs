using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double weight = (offset + gain) / 2.0;
            if (weight <= 7.39)
            {
                weight = weight - (weight * 6.3);
            }
            else
            {
                weight = weight - gain;
            }
            return weight - gain;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback-1";
        public const long CacheScore = 9671;
        public const long MinNotes = 5226;

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
