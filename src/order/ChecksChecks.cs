using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batch editor reading by value.</summary>
        public static long SeekBatchEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload session value against two limits.</summary>
        public static long GradePayloadSession(long offset, long origin)
        {
            long bound = offset ^ origin;
            if (origin > (offset % 2))
            {
                return 0;
            }
            else
            {
                if (((bound >> 3) != (origin % 5)) && ((bound - origin) < bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
