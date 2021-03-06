/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Hadoop.Hive
{

  [Serializable]
  public partial class Schema : TBase
  {
    private List<FieldSchema> _fieldSchemas;
    private Dictionary<string, string> _properties;

    public List<FieldSchema> FieldSchemas
    {
      get
      {
        return _fieldSchemas;
      }
      set
      {
        __isset.fieldSchemas = true;
        this._fieldSchemas = value;
      }
    }

    public Dictionary<string, string> Properties
    {
      get
      {
        return _properties;
      }
      set
      {
        __isset.properties = true;
        this._properties = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool fieldSchemas;
      public bool properties;
    }

    public Schema() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                FieldSchemas = new List<FieldSchema>();
                TList _list89 = iprot.ReadListBegin();
                for( int _i90 = 0; _i90 < _list89.Count; ++_i90)
                {
                  FieldSchema _elem91 = new FieldSchema();
                  _elem91 = new FieldSchema();
                  _elem91.Read(iprot);
                  FieldSchemas.Add(_elem91);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Map) {
              {
                Properties = new Dictionary<string, string>();
                TMap _map92 = iprot.ReadMapBegin();
                for( int _i93 = 0; _i93 < _map92.Count; ++_i93)
                {
                  string _key94;
                  string _val95;
                  _key94 = iprot.ReadString();
                  _val95 = iprot.ReadString();
                  Properties[_key94] = _val95;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Schema");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (FieldSchemas != null && __isset.fieldSchemas) {
        field.Name = "fieldSchemas";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, FieldSchemas.Count));
          foreach (FieldSchema _iter96 in FieldSchemas)
          {
            _iter96.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Properties != null && __isset.properties) {
        field.Name = "properties";
        field.Type = TType.Map;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, Properties.Count));
          foreach (string _iter97 in Properties.Keys)
          {
            oprot.WriteString(_iter97);
            oprot.WriteString(Properties[_iter97]);
            oprot.WriteMapEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Schema(");
      sb.Append("FieldSchemas: ");
      sb.Append(FieldSchemas);
      sb.Append(",Properties: ");
      sb.Append(Properties);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
