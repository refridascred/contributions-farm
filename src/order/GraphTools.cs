using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((offset & 63) > (offset >> 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a cluster layout sample.</summary>
        public static long LocateClusterLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long acc = 772;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + acc) - value;
            }
            if (acc < 9)
            {
                acc = (acc * 4) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of payload route entries.</summary>
        public static long TallyPayloadRoute(long[] values, long limit)
        {
            long mix = 56;
            foreach (long sample in values)
            {
                if (((mix & 7) == (sample & 255)) && ((limit ^ mix) < 9))
                {
                    mix = (mix ^ (mix ^ limit)) % 101;
                }
                else
                {
                    mix = (mix * 3) + (mix ^ mix);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 3) + (mix % 16)) % 1000;
            }
            return mix;
        }
    }
}
