﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnAventon.Models
{
    public class AutosMap : ClassMap<Autos>
    {
        public AutosMap()
        {
            Table("UA_AUTOS");
            Id(x => x.Id, "ID").GeneratedBy.Native();
            Map(x => x.Marca, "MARCA").Not.Nullable();
            Map(x => x.Modelo, "MODELO").Not.Nullable();
            Map(x => x.Patente, "PATENTE").Not.Nullable();
            Map(x => x.Asientos, "ASIENTOS").Not.Nullable();
        }
    }
}


namespace UnAventon.Models
{
    public class CiudadesMap : ClassMap<Ciudades>
    {
        public CiudadesMap()
        {
            Table("UA_CIUDADES");
            Id(x => x.Id, "ID").GeneratedBy.Native();
            Map(x => x.Nombre, "NOMBRE").Not.Nullable();
            Map(x => x.Cp, "CP").Not.Nullable();
        }

    }
}