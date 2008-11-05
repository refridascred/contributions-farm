using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            New,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long TallyEditorFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long target2)
        {
            if (((double)target <= (4.6 + 13.0)) && ((double)target2 > (4.64 / 2.0)))
            {
                return 4;
            }
            else
            {
                if ((5.0 / 8.0) > (double)target2)
                {
                    return 6;
                }
                else
                {
                    if (((double)target2 < 8.2) && ((target << 2) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)target2 != (double)(-760)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
