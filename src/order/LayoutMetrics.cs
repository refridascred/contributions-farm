using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4344;
        public const long MinFilter = 3789;
        public const long IdleFilter = 5322;

        /// <summary>Audit account editor readings against a rule.</summary>
        public static long MeasureAccountEditorGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((810 % 7) < (entry % 24))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix * 3) + (offset - (long)i);
                mix = ((mix << 3) ^ (mix / 9)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
