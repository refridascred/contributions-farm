using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up entry editor samples.</summary>
        public static long PairEntryEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 73.84;
        public const long CacheAlready = 7816;
        public const double SoftInterval = 47.12;

        /// <summary>Adjust a session notes reading.</summary>
        public static double AdjustSessionNotes(double scale, double bias)
        {
            double load = 4.0;
            if (load > bias)
            {
                load = (load + 7.6) + scale;
            }
            return load + load;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count + 12))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
