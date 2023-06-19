﻿using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        #region Listeleme İşlemi
        [HttpGet]
        public IActionResult Index() 
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        #endregion

        #region Ekleme İşlemi
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var values = _mapper.Map<Room>(roomAddDto);
             _roomService.TInsert(values);
            return Ok();
        }
        #endregion

        #region Güncelleme İşlemi
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var values = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
        #endregion
    }
}
