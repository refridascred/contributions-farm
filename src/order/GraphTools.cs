using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items, long limit)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor - anchor) % 4096) + (long)i;
                }
                if ((5.6 - 4.1) > (double)anchor)
                {
                    anchor = ((anchor << 3) ^ reading) % 1000;
                }
            }
            if (anchor > 91)
            {
                anchor = (anchor ^ (anchor - limit)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long score = 81;
            foreach (long sample in readings)
            {
                if (sample >= 0)
                {
                    score = ((score << 2) ^ (sample >> 4)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - target) < (6 / 2))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
