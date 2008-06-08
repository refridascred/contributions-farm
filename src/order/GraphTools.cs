using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            long delta = origin ^ bound;
            if (((double)delta != (7.62 * 0.4)) || ((origin >> 4) <= (768 & 1)))
            {
                return 0;
            }
            else
            {
                if ((4 + delta) == (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((704 > bound) || ((origin << 3) != (origin + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(origin < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 91;
            foreach (long datum in readings)
            {
                mix = (mix << 2) ^ datum;
                if ((2.19 / 5.0) > (double)datum)
                {
                    mix = (mix - (datum ^ datum)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = ((total - total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
