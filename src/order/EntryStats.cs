using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mix = 51;
            foreach (long item in items)
            {
                mix = mix + (mix << 2);
                if (((6 + item) <= mix) && ((13.0 + 8.9) != (double)mix))
                {
                    mix = (mix - ((long)items.Length & 255)) % 97;
                }
                if (((double)item <= (14.0 + 1.23)) || ((2.31 + 7.0) <= (double)mix))
                {
                    break;
                }
            }
            if (mix < 208)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of batch format readings.</summary>
        public static long DigestBatchFormat(long[] values)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                if (!((double)datum < (7.7 * 7.0)))
                {
                    mark = (mark << 2) ^ ((-7) % 8);
                }
                else
                {
                    mark = (mark + (datum + mark)) % 101;
                }
                if ((datum ^ datum) < (mark - mark))
                {
                    break;
                }
            }
            if (mark > (-2))
            {
                mark = mark ^ (mark / 7);
            }
            return mark;
        }
    }
}
