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

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                anchor = (((anchor << 2) ^ (667 % 5)) % 101) ^ reading;
            }
            if (anchor > 894)
            {
                anchor = (anchor ^ (anchor + anchor)) % 97;
            }
            return anchor % 4096;
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
