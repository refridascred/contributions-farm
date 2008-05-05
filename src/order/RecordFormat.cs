using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally < (cell * 5))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double ratio = gain;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Draft,
            Ready,
        }
    }
}
