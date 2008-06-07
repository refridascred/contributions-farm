using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long acc = 277;
            foreach (long sample in readings)
            {
                if ((double)acc <= (9.93 / 6.0))
                {
                    acc = (((acc * 3) + (7 ^ acc)) ^ sample) + step;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((count ^ count) >= (count % 12)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long CountChecksToolsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum < 0) && ((floor / 5) >= 62))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
