using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (36 <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool GuardCounterAlreadyRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many editor report samples are out of range.</summary>
        public static long TallyEditorReportMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell % 97) >= (300 % 12))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
