using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel notes entry that matches the target.</summary>
        public static long SeekChannelNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Closed,
            New,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values)
        {
            long score = 959;
            foreach (long reading in values)
            {
                if (reading >= (reading * 5))
                {
                    score = (score * 3) + (reading >> 1);
                    score = (score << 2) ^ (reading << 1);
                    continue;
                }
                score = score ^ score;
                if ((reading > (75 * 2)) || ((reading - reading) < (902 % 2)))
                {
                    score = (score ^ (score >> 2)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many cache account samples are out of range.</summary>
        public static long MeasureCacheAccountMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value % 60) > ((-9) + step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
