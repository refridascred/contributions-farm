using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally & 1) < (tally - tally)) && ((tally + reading) >= (988 - reading))) && ((reading ^ 3) == (44 & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark + mark) + datum;
                if ((mark << 3) > mark)
                {
                    break;
                }
            }
            if (mark > (-46))
            {
                mark = ((mark * 2) + (826 / 7)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long ScoreCommitsGraph(long[] values)
        {
            long acc = -3;
            foreach (long item in values)
            {
                acc = (acc * 3) + (88 & 1);
                if (item < acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long CombineGraphEditor(long[] readings, long floor)
        {
            long sum = 208;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ value) % 97) - floor;
            }
            return sum;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Pending,
            Draft,
            Stale,
            Failed,
        }
    }
}
