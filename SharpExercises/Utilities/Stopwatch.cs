using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.Utilities
{
    /// <summary>
    /// Class that provides a stopwatch functionality
    /// </summary>
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;
        public bool IsRunning 
        {
            get { return _isRunning; }
        }

        /// <summary>
        /// Start the stopwatch
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception> If the stopwatch is already running
        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        /// <summary>
        /// Stop the stopwatch
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception> If the stopwatch is not running
        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            _endTime = DateTime.Now;
            _isRunning = false;
        }

        /// <summary>
        /// Get the duration of the stopwatch
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception> If the stopwatch is still running
        public TimeSpan GetDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is still running.");

            return _endTime - _startTime;
        }
    }
}
