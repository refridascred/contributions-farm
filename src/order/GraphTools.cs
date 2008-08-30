using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches + (-24)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor filter entry stays within the limit.</summary>
        public static bool VerifyEditorFilterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long anchor = 12;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 3) ^ (16 / 7)) % 4096;
                if ((entry - 7) <= (7 ^ entry))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
