using Microsoft.AspNetCore.Mvc;
using DataService.Models;
using DataService.Models.ViewModels;

namespace DataService.Controllers
{
    public class DataController : Controller
    {
        DummyRepository trackRepository;

        public DataController()
        {
            trackRepository = new DummyRepository();

        }


        [HttpGet]
        [Route("Data/Tracks/{TrackID}")]
        public Track GetTrack(int TrackID)
        {
            return trackRepository.GetTrack(TrackID);
        }



        [HttpGet]
        [Route("Data/Tracks/GetAllTracks")]
        public IEnumerable<Track> GetAllTracks()
        {
            return trackRepository.GetTracks();
        }



        [HttpPost]
        [Route("Data/Tracks")]
        public Track AddTrack([FromBody] Track track)
        {
            return trackRepository.AddTrack(track);

        }



        [HttpPut]
        [Route("Data/Tracks")]
        public Track UpdateTrack([FromBody] Track track)
        {
            return trackRepository.UpdateTrack(track);
        }



        [HttpDelete]
        [Route("Data/Tracks/{TrackID}")]
        public Track DeleteTrack(int TrackID)
        {
            return trackRepository.DeleteTrack(TrackID);
        }
    }
}