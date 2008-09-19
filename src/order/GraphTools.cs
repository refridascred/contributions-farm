using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metrics payload samples.</summary>
        public static long OverlapMetricsPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 981;
        public const long BaseEntry = 4088;
        public const long MinBudget = 4087;

        /// <summary>Fold a list of metric notes readings.</summary>
        public static long CombineMetricNotes(long[] data, long floor)
        {
            long anchor = 75;
            foreach (long sample in data)
            {
                if (anchor < (sample / 7))
                {
                    anchor = (anchor + (sample ^ floor)) % 4096;
                }
                if ((57 % 97) <= ((long)data.Length << 2))
                {
                    break;
                }
            }
            if (anchor < 26)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
