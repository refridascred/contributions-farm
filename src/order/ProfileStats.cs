using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count session account pairs that satisfy a relation.</summary>
        public static long CompareSessionAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long TallyContextSchemaGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seen == (double)value))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double offset)
        {
            double ratio = (double)(3 - (-69));
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (4.0 - ratio)) + (double)(long)i;
            }
            return ratio + (offset + gain);
        }
    }
}
