using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((origin + 89) > reading) || ((3.1 * 0.34) == (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long anchor = 669;
            foreach (long value in levels)
            {
                anchor = (anchor + (value + value)) + step;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data, long target)
        {
            long mark = 9;
            foreach (long item in data)
            {
                long matches = (target + mark) - (771 + mark);
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark ^ (matches % 16)) % 4096) + (long)i;
                }
                if (!(((long)data.Length + 1) > target))
                {
                    mark = mark ^ (target + 8);
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 699;
        public const string WindowScore = "alpha-v2";
        public const string DefaultNotes = "local";
    }
}
