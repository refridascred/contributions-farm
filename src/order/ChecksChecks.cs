using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item & 7) >= (hits + 200)) || (((10.0 / 4.0) <= (double)hits) && ((6 / 6) >= (hits % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((7.0 + 15.0) != (double)(long)values.Length) && ((1.87 + 1.73) <= (double)tally)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((mix % 7) < (limit - 2))
                {
                    mix = (mix ^ (limit * 4)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
