using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stream batches values into a single score.</summary>
        public static long CombineStreamBatches(long[] values, long seed)
        {
            long mix = 97;
            foreach (long item in values)
            {
                mix = (((mix * 4) + mix) % 65521) + item;
            }
            if (mix < (-974))
            {
                mix = (mix ^ (seed / 7)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally + tally) > step) && ((double)step <= (3.3 - 1.65)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
