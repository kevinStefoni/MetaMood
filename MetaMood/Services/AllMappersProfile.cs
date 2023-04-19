using MetaMood.Models;
using AutoMapper;

namespace MetaMood.Services
{
    public class AllMappersProfile : Profile
    {

        /// <summary>
        /// This method maps DTOs to their entity model counterparts, ignoring attributes that will not be directly displayed
        /// to users.
        /// </summary>
        public AllMappersProfile()
        {

            CreateMap<TrackAudioFeatures, SpotifyTrackDTO>();
            CreateMap<SpotifyTrackDTO, TrackAudioFeatures>().ForMember(t => t.TrackId, opt => opt.Ignore())
                                                      .ForMember(t => t.TrackHref, opt => opt.Ignore())
                                                      .ForMember(t => t.Key, opt => opt.Ignore())
                                                      .ForMember(t => t.Mode, opt => opt.Ignore())
                                                      .ForMember(t => t.Type, opt => opt.Ignore())
                                                      .ForMember(t => t.Uri, opt => opt.Ignore())
                                                      .ForMember(t => t.AnalysisUrl, opt => opt.Ignore())
                                                      .ForMember(t => t.DurationMs, opt => opt.Ignore())
                                                      .ForMember(t => t.TimeSignature, opt => opt.Ignore())
                                                      .ForMember(t => t.Acousticness, opt => opt.MapFrom(src => src.Acousticness))
                                                      .ForMember(t => t.Danceability, opt => opt.MapFrom(src => src.Danceability))
                                                      .ForMember(t => t.Energy, opt => opt.MapFrom(src => src.Energy))
                                                      .ForMember(t => t.Liveness, opt => opt.MapFrom(src => src.Liveness))
                                                      .ForMember(t => t.Loudness, opt => opt.MapFrom(src => src.Loudness))
                                                      .ForMember(t => t.Speechiness, opt => opt.MapFrom(src => src.Speechiness))
                                                      .ForMember(t => t.Tempo, opt => opt.MapFrom(src => src.Tempo))
                                                      .ForMember(t => t.Instrumentalness, opt => opt.MapFrom(src => src.Instrumentalness))
                                                      .ForMember(t => t.Valence, opt => opt.MapFrom(src => src.Valence));


        }
    }
}
