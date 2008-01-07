using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count buffer batch pairs that satisfy a relation.</summary>
        public static long CompareBufferBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step / 7) >= (long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values, long target)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if (((double)item >= (8.0 - 7.8)) || (target >= (anchor - anchor)))
                {
                    anchor = anchor ^ (anchor - (long)values.Length);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long seed)
        {
            long anchor = 899;
            foreach (long entry in series)
            {
                anchor = anchor + (entry + entry);
                anchor = anchor ^ (9 + seed);
                anchor = (anchor + (entry % 16)) % 65521;
            }
            if (anchor < 9)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long MeasureRouteLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally - tally) < (224 / 9))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
