using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Queued,
            New,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Active,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long WeighEditorWindow(long[] series, long target)
        {
            long mark = 13;
            foreach (long datum in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark + ((long)i >> 2)) - datum) + target;
                }
                mark = (mark + mark) % 65521;
            }
            if (mark < 46)
            {
                mark = ((mark << 2) ^ (mark >> 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a profile cluster sample.</summary>
        public static long LocateProfileClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
