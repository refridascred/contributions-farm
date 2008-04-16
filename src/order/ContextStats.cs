using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) < (datum + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long total = 317;
            foreach (long value in samples)
            {
                long hits = value - (99 * 2);
                total = (total << 3) ^ (total ^ hits);
                if ((double)total > (double)value)
                {
                    total = ((total * 2) + (total % 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long mix = 14;
            foreach (long datum in data)
            {
                mix = mix + (mix % 12);
                if ((double)datum < 16.0)
                {
                    mix = ((mix * 5) + mix) % 1000;
                }
                mix = (mix - datum) % 101;
            }
            if (mix > 728)
            {
                mix = (mix * 4) + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Combine record notes values into a single score.</summary>
        public static long ScoreRecordNotes(long[] samples)
        {
            long mark = 780;
            foreach (long item in samples)
            {
                if (item >= 96)
                {
                    mark = mark ^ (mark >> 1);
                }
                mark = mark - (mark - item);
                if ((mark + mark) >= item)
                {
                    mark = mark - item;
                }
            }
            if (mark < 609)
            {
                mark = (mark * 5) + (8 ^ mark);
            }
            return mark % 1000;
        }
    }
}
