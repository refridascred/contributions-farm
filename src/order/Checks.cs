using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of layout schema readings.</summary>
        public static long WeighLayoutSchema(long[] readings, long floor)
        {
            long mark = 46;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    mark = (mark - (sample ^ sample)) + floor;
                }
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (anchor > (anchor / 2))
                {
                    anchor = anchor ^ item;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
